using System;
using System.Collections.Generic;

namespace ListSamples
{
    public enum CompareType
    {
        FirstName,
        LastName,
        Country,
        Wins
    }

    public class RacerComparer : IComparer<Racer>
    {
        private CompareType _compareType;
        public RacerComparer(CompareType compareType)
        {
            _compareType = compareType;
        }

        public int Compare(Racer x, Racer y)
        {
            int CountryComparer(Racer x1, Racer y1)
            {
                int result = string.Compare(x1.Country, y1.Country);
                if (result == 0)
                {
                    return string.Compare(x1.LastName, y1.LastName);
                }
                else
                {
                    return result;
                }
            }

            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            switch (_compareType)
            {
                case CompareType.FirstName:
                    return string.Compare(x.FirstName, y.FirstName);
                case CompareType.LastName:
                    return string.Compare(x.LastName, y.LastName);
                case CompareType.Country:
                    return CountryComparer(x, y);
                case CompareType.Wins:
                    return x.Wins.CompareTo(y.Wins);
                default:
                    throw new ArgumentException("Invalid Compare Type");
            }
        }
    }
}