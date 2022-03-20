using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleResponsibility
{
    /* 
                Single Responsibility Principle
    
    * A class hould only have a single responsiblitiy.
        
    * Single reason for change and encapsulated class.
    
    * Create different-2 interface.
    
    * KISS (Keep it simple stupid :) )
    
    * Small is simple, big is complex.
    
    */


    //Bad approach
    public interface IReportBad
    {

        //Report tracking methods
        void AddEntryAt(int index); // Tracking report
        void RemoveEntryAt(int index); // Tracking report

        //Report file operation method
        void SaveToFile(string directoryPath, string fileName); // File operation
    }


    //Better approach
    public interface IReportTracking{

        void AddEntryAt(int index); 
        void RemoveEntryAt(int index);
    }

    public interface IReportFileOperations {

        void SaveToFile(string directoryPath, string fileName);
    }
}
