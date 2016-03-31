using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04day01
{
    class Combination<T, U>
    {
        private T itemOne;
        private T itemTwo;
        private T itemThree;

        private U itemFour;
        private U itemFive;
        private U itemSix;

        public Combination(T itemOne, T itemTwo, T itemThree, U itemFour, U itemFive, U itemSix)
        {
            this.itemOne = itemOne;
            this.itemTwo = itemTwo;
            this.itemThree = itemThree;

            this.itemFour = itemFour;
            this.itemFive = itemFive;
            this.itemSix = itemSix;
        }

        public override bool Equals(object obj)
        {
            if ((obj as Combination<T, U>).itemOne.Equals(itemOne) &&
                (obj as Combination<T, U>).itemTwo.Equals(itemTwo) &&
                (obj as Combination<T, U>).itemThree.Equals(itemThree) &&
                (obj as Combination<T, U>).itemFour.Equals(itemFour) &&
                (obj as Combination<T, U>).itemFive.Equals(itemFive) &&
                (obj as Combination<T, U>).itemSix.Equals(itemSix))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + itemOne.GetHashCode();
                hash = hash * 23 + itemTwo.GetHashCode();
                hash = hash * 23 + itemThree.GetHashCode();
                hash = hash * 23 + itemFour.GetHashCode();
                hash = hash * 23 + itemFive.GetHashCode();
                hash = hash * 23 + itemSix.GetHashCode();
                return hash;
            }
        }
    }
}
