using FunkyCode.Entities.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSubstituteTests
{
    public class Class_A : Interface_A

    {
        private readonly Interface_B interface_B;
        private readonly Interface_C interface_C;

        public Class_A(Interface_B interface_B, Interface_C interface_C)
        {
           
            this.interface_B = interface_B;
            this.interface_C = interface_C;
        }

        public void Method_A() {

            var val = interface_B.Method_B();
            interface_C.Method_C();
        }
    }

    public class Class_B : Interface_B

    {
        private readonly Interface_D interface_D;
        private readonly Interface_E interface_E;

        public Class_B(Interface_D interface_D, Interface_E interface_E)
        {
            this.interface_D = interface_D;
            this.interface_E = interface_E;
        }

        public int Method_B()
        {
            interface_D.Method_D();
            return 0;
        }
    }

    public class Class_C : Interface_C

    {
        public void Method_C() { }
    }

    public class Class_D : Interface_D

    {
        public void Method_D() { }
    }

    public class Class_E : Interface_E

    {
        public void Method_E() { }
    }

    public class Class_F : Interface_F

    {
        public void Method_F() { }
    }

    public class Class_G : Interface_G

    {
        public void Method_G() { }
    }
}
