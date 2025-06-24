using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern_ex
{

    using System;
    interface idoc
    {
        void open();
    }
    class pdfdocument : idoc
    {
        public void open()
        {
            Console.WriteLine("Opening PDF Document...");
        }
    }
    class worddocument : idoc
    {
        public void open()
        {
            Console.WriteLine("Opening Word Document...");
        }
    }
    class exceldocument : idoc
    {
        public void open()
        {
            Console.WriteLine("Opening Excel Document...");
        }
    }
    abstract class docfactory
    {

        public abstract idoc createdoc(); 
    }
    class pdfdocfact: docfactory
    {
        public override idoc createdoc()
        {
            return new pdfdocument();
        }
    }
    class worddocfact : docfactory
    {
        public override idoc createdoc()
        {
            return new worddocument();
        }
    }
    class exceldocfact : docfactory
    {
        public override idoc createdoc()
        {
            return new exceldocument();
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            docfactory word = new worddocfact();
            idoc Worddoc = word.createdoc();
            Worddoc.open();

            docfactory pdf = new pdfdocfact();
            idoc Pdfdoc = pdf.createdoc();
            Pdfdoc.open();

            docfactory excel = new exceldocfact();
            idoc Exceldoc = excel.createdoc();
            Exceldoc.open();
        }
    }

}
