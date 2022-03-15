using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    /* 
                Interface Segregation Principle
    
    * Many client-specific interfaces are better than one general-purpose
    big interface.
    
    * Interface only useful interfaces. Not implement a big interface.
    
    * Broken the big interface into usefull small interfaces.
    
    * Implement multiple interfaces where required.
    
     */ 


    //Bad approach

    public interface IPrintTasks
    {
        bool PrintContent(string content);
        bool CopyContent(string content);
        bool ScanDocument(string content);
    }

    //Has no copy functuality
    public class HpPrinter : IPrintTasks
    {
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done");
            return true;
        }

        public bool CopyContent(string content)
        {
            return false;
        }


        public bool ScanDocument(string content)
        {
            Console.WriteLine("Scanning Done");
            return true;
        }
    }

    //Has no scan functuality
    public class CannonPrinter : IPrintTasks
    {
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done");
            return true;
        }

        public bool CopyContent(string content)
        {
            Console.WriteLine("Copy Done");
            return true;
        }


        public bool ScanDocument(string content)
        {
            return false;
        }
    }

    //Better Approach

    public interface IPrintContent
    {
        bool PrintContent(string content);
    }

    public interface ICopyContent
    {
        bool CopyContent(string content);
    }

    public interface IScanContent
    {
        bool ScanContent(string content);
    }

    public class NewHpPrinter : IPrintContent, ICopyContent
    {
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done");
            return true;
        }

        public bool CopyContent(string content)
        {
            Console.WriteLine("Copy Done");
            return true;
        }

    }

    public class NewCannonPrinter : IPrintContent, IScanContent
    {
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done");
            return true;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("Scanning Done");
            return true;
        }
    }
}
