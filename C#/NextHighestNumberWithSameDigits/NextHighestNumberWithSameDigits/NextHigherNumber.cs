using System;
using System.Linq;

namespace NextHighestNumberWithSameDigits {

    public static class NextHigherNumber {

        private static int ToNumber(this int[] source) => source.Aggregate((left, right) => (10 * left + right));

        private static int[] ToDigits(this int source) => source.ToString().Select(x => Convert.ToInt32(x.ToString())).ToArray();

        private static Action<int[], int, int> Swap = (int[] source, int indexFrom, int indexTo) => {
            var temp = source[indexTo];
            source[indexTo] = source[indexFrom];
            source[indexFrom] = temp;
        };

        public static int GiveNextHighestNumber(int input) {

            int[] splitValues = input.ToDigits();

            int indexOfElementGreatThanPrevious = FindElementGreaterThanNextElementStartingFromRight(splitValues);

            if (indexOfElementGreatThanPrevious == 0) return input;

            int indexOfPivotElement = indexOfElementGreatThanPrevious - 1;
            int indexOfElementNextToPivot = indexOfPivotElement + 1;
            int indexOfSmallestButGreaterThanPivotAtTheRightOfPivot = indexOfPivotElement + 1;

            indexOfSmallestButGreaterThanPivotAtTheRightOfPivot =
                IndexOfSmallestButGreaterThanPivotAtTheRightOfPivot(splitValues,
                                                                    indexOfPivotElement,
                                                                    indexOfSmallestButGreaterThanPivotAtTheRightOfPivot);

            Swap(splitValues, indexOfSmallestButGreaterThanPivotAtTheRightOfPivot, indexOfPivotElement);

            var finalNumbers = splitValues.Take(indexOfElementNextToPivot).Concat(splitValues.Skip(indexOfElementNextToPivot).OrderBy(x => x)).ToArray();

            return finalNumbers.ToNumber();
        }

        private static Func<int[], int> FindElementGreaterThanNextElementStartingFromRight = (int[] source) => {
            int index = 0;
            for (index = source.Length - 1; index > 0; index--) {
                if (source[index] > source[index - 1])
                    break;
            }
            return index;
        };

        private static int IndexOfSmallestButGreaterThanPivotAtTheRightOfPivot(int[] splitValues, int indexOfPivotElement, int indexOfSmallestButGreaterThanPivotAtTheRightOfPivot) {
            int pivotElement = splitValues[indexOfPivotElement];
            int i = 0;
            for (i = indexOfPivotElement + 1; i < splitValues.Length; i++) {
                if (splitValues[i] < splitValues[indexOfSmallestButGreaterThanPivotAtTheRightOfPivot] && splitValues[i] > pivotElement)
                    indexOfSmallestButGreaterThanPivotAtTheRightOfPivot = i;
            }

            return indexOfSmallestButGreaterThanPivotAtTheRightOfPivot;
        }
    }
}
