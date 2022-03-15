using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{

    /* 
                Dependency Inversion Principle
    
    * One should "depend upon abstractions, [not] concreations."
    
    * Detail should depend on abstractions and abstraction 
     should not depend on details.
    
    * High level module should not depend on low level module and
    both should depend on abstractions.

    *Adapter design pattern implement the dependecy inversion principle.
    
    *Eg. Implement the repository pattern between business and data base layer.
        
    */


    //Bad approach

    public class DataAccessLayerBad
    {
        public void Save(Object details)
        {
            //perform save
        }
    }
    public class BusinessLogicLayerBad
    {
        private readonly DataAccessLayerBad DAL;

        public BusinessLogicLayerBad()
        {
            DAL = new DataAccessLayerBad();
        }

    }

    //Better approach
    public interface IRepositoryLayer
    {
        void Save(Object details);
    }

    public class DataAccessLayer : IRepositoryLayer
    {
        public void Save(object details)
        {
            //perform save
        }
    }

    public class BusinessLogicLayer
    {
        private readonly IRepositoryLayer _repositoryLayer;

        public BusinessLogicLayer(IRepositoryLayer repositoryLayer)
        {
            _repositoryLayer = repositoryLayer;
        }

        public void Save(Object details)
        {
            _repositoryLayer.Save(details);
        }
    }
}
