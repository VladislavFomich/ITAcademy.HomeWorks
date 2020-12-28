using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    abstract class Catalog
    {
      public string name;
      public Guid id;
      public string category;
      public int size;
      public void Play() { }
      public void RetrieveInformation() { }
    }

    class Films : Catalog
    {
        public string producer;
        public string mainActor;
        public string mainActress;      
    } 

    class Music : Catalog
    {
        public string performer;
        public int lenght;
    }
}
