using System;
using System.Collections.Generic;
using System.Text;

namespace SwapGenerisk {

    class Swap<T> {

        public  Swap(ref T thing1, ref T thing2) {
            T temp = thing1;
            thing1 = thing2;
            thing2 = temp;
        }
    }
}
