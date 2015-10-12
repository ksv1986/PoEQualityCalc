using System;
using System.Collections.Generic;

namespace PoE
{
    static class Limits
    {
        public const int MaxQuality = 19;
        public const int VendoredQuality = 40;
    }

    public class QualityQuantities : IComparable<QualityQuantities>, ICloneable
    {
        private int[] quantity;

        public int Count { get; private set; }
        public int Sum { get; private set; }

        public QualityQuantities()
        {
            quantity = new int[Limits.MaxQuality];
            Sum = 0;
            Count = 0;
        }

        public QualityQuantities(QualityQuantities other)
        {
            quantity = (int[])other.quantity.Clone();
            Sum = other.Sum;
            Count = other.Count;
        }

        public static QualityQuantities operator +(QualityQuantities left, QualityQuantities right)
        {
            var result = new QualityQuantities(left);
            for (var i = 0; i < result.quantity.Length; i++)
                result.quantity[i] += right.quantity[i];
            result.Sum += right.Sum;
            result.Count += right.Count;
            return result;
        }

        public void Clear()
        {
            Array.Clear(quantity, 0, quantity.Length);
            Sum = 0;
            Count = 0;
        }

        public object Clone()
        {
            return new QualityQuantities(this);
        }

        public int CompareTo(QualityQuantities other)
        {
            var result = Sum.CompareTo(other.Sum);
            if (result != 0)
                return result;

            result = Count.CompareTo(other.Count);
            if (result != 0)
                return -result;

            for (var i = 0; i < quantity.Length; i++)
            {
                result = quantity[i].CompareTo(other.quantity[i]);
                if (result != 0)
                    return result;
            }

            return 0;
        }

        public bool IsSubsetOf(QualityQuantities other)
        {
            if (Sum > other.Sum)
                return false;

            if (Count > other.Count)
                return false;

            for (var i = 0; i < quantity.Length; i++)
            {
                if (quantity[i] > other.quantity[i])
                    return false;
            }

            return true;
        }

        public void Subtract(QualityQuantities other)
        {
            if (!other.IsSubsetOf(this))
                throw new ApplicationException("Subtracted quantities must be a subset of minuend");

            Count -= other.Count;
            Sum -= other.Sum;
            for (var i = 0; i < quantity.Length; i++)
                quantity[i] -= other.quantity[i];
        }

        private void CheckQualityRange(int quality)
        {
            if (quality < 1 || quality > Limits.MaxQuality)
                throw new ArgumentOutOfRangeException("Quality", "Quality must be within [1.." + Limits.MaxQuality.ToString() + "] range");
        }

        public void IncreaseQuantityOf(int quality)
        {
            CheckQualityRange(quality);
            IncreaseQuantityAtIndex(quality - 1);
        }

        public void DecreaseQuantityOf(int quality)
        {
            CheckQualityRange(quality);
            DecreaseQuantityAtIndex(quality - 1);
        }

        public int At(int quality)
        {
            CheckQualityRange(quality);
            return quantity[quality - 1];
        }

        private void IncreaseQuantityAtIndex(int index)
        {
            quantity[index]++;
            Count += 1;
            Sum += (index + 1);
        }

        private void DecreaseQuantityAtIndex(int index)
        {
            if (quantity[index] == 0)
                return;

            quantity[index]--;
            Count -= 1;
            Sum -= (index + 1);
        }

        private void ResetQuantityAtIndex(int index)
        {
            Count -= quantity[index];
            Sum -= quantity[index] * (index + 1);
            quantity[index] = 0;
        }

        private void FindDeals(int index, QualityQuantities deal, List<QualityQuantities> allDeals)
        {
            while (index < Limits.MaxQuality)
            {
                while (deal.quantity[index] < quantity[index])
                {
                    deal.IncreaseQuantityAtIndex(index);
                    if (deal.Sum >= Limits.VendoredQuality)
                    {
                        allDeals.Add(new QualityQuantities(deal));
                        break;
                    }

                    FindDeals(index + 1, deal, allDeals);
                }
                deal.ResetQuantityAtIndex(index);
                index++;
            }
        }

        public List<QualityQuantities> FindAllPossibleDeals()
        {
            var allDeals = new List<QualityQuantities>();
            FindDeals(0, new QualityQuantities(), allDeals);
            allDeals.Sort();
            return allDeals;
        }

        internal class BestDeals
        {
            private List<QualityQuantities> allDeals;
            private QualityQuantities allItems;
            private int optimalCount;
            private int bestCount;
            private int[] bestDeals;

            public BestDeals(QualityQuantities allItems, List<QualityQuantities> allDeals)
            {
                this.allItems = allItems;
                this.allDeals = allDeals;
                bestCount = 0;
                for (
                    optimalCount = 0;
                    optimalCount < allDeals.Count && allDeals[optimalCount].Sum == Limits.VendoredQuality;
                    optimalCount++
                );
            }

            private void Find(int[] deals, int dealsCount, int index, QualityQuantities currentDeal)
            {
                if (!currentDeal.IsSubsetOf(allItems))
                    return;

                if (bestCount < dealsCount)
                {
                    bestCount = dealsCount;
                    bestDeals = (int[])deals.Clone();
                }

                while (index < optimalCount)
                {
                    var nextDeals = (int[])deals.Clone();
                    nextDeals[index]++;
                    Find(nextDeals, dealsCount + 1, index, currentDeal + allDeals[index]);
                    index++;
                }
            }

            public List<QualityQuantities> Find()
            {
                Find(new int[optimalCount], 0, 0, new QualityQuantities());

                var result = new List<QualityQuantities>(bestCount);
                for (var i = 0; i < optimalCount; i++)
                    for (var j = 0; j < bestDeals[i]; j++)
                        result.Add(allDeals[i]);
                return result;
            }
        }

        public List<QualityQuantities> FindBestDeals(List<QualityQuantities> allDeals)
        {
            return new BestDeals(this, allDeals).Find();
        }
    }
}
