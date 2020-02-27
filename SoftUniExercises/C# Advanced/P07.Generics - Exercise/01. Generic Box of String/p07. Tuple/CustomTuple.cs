using System;
using System.Collections.Generic;
using System.Text;

namespace CustomizedTuple
{
    /// <summary>
    /// Tf is first item and Ts is seconds item
    /// </summary>
    /// <typeparam name="Tf"></typeparam>
    /// <typeparam name="Ts"></typeparam>
    class CustomTuple<Tf,Ts,Tth>
    {
        public Tf FirstItem { get; set; }

        public Ts SecondItem { get; set; }

        public Tth ThirtdItem { get; set; }

        private CustomTuple()
        {
            var initializeItems = new Tf[3];
        }

        public CustomTuple(Tf firstInput, Ts secondInput, Tth thirdItem)
            : this()
        {
            this.FirstItem = firstInput;
            this.SecondItem = secondInput;
            this.ThirtdItem = thirdItem;
        }

        public override string ToString() => $"{this.FirstItem} -> {this.SecondItem} -> {this.ThirtdItem}";
        
    }
}
