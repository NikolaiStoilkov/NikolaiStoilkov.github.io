using System;
using System.Collections.Generic;
using System.Text;

namespace CustomizedTuple
{
    class CustomTuple<Tf,Ts>
    {
        public Tf FirstItem { get; set; }

        public Ts SecondItem { get; set; }

        private CustomTuple()
        {
            var initializeItems = new Tf[2];
        }

        public CustomTuple(Tf firstInput, Ts secondInput)
            : this()
        {
            this.FirstItem = firstInput;
            this.SecondItem = secondInput;
        }

        public override string ToString() => $"{this.FirstItem} -> {this.SecondItem}";
        
    }
}
