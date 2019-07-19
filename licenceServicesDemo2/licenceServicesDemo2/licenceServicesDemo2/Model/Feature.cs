using System;
using System.Collections.Generic;
using System.Text;

namespace licenceServicesDemo2.Model
{
    public class Feature
    {
        public string FeatureName { get; set; }

        public double Ver { get; set; }

        public int count { get; set; }

        public int Available { get; set; }

        public string ExperyDate { get; set; }

        //public Feature()
        //{
        //    LoadData();
        //}

        //private void LoadData()
        //{
        //    var Featurelist = new List<Feature>();

        //    Featurelist.Add(new Feature() { FeatureName = "f2", Ver = (float)2.0, count = 1, Available = 1, ExperyDate = "Permanent" });

        //    Featurelist.Add(new Feature() { FeatureName = "f2", Ver = (float)1.0, count = 100, Available = 92, ExperyDate = "Permanent" });

        //    Featurelist.Add(new Feature() { FeatureName = "f3", Ver = (float)1.0, count = 10, Available = 5, ExperyDate = "2021-01-31" });

        //    Featurelist.Add(new Feature() { FeatureName = "f1", Ver = (float)1.0, count = 15, Available = 5, ExperyDate = "2020-01-31" });
        //}
    }
}
