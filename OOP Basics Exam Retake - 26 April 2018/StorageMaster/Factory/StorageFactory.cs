﻿using StorageMaster.Model.Storages;
using System;

namespace StorageMaster.Factory
{
    public class StorageFactory
    {
        public Storage CreateStorage(string type,string name)
        {
            switch (type)
            {
                case "AutomatedWarehouse": return new AutomatedWarehouse(name);
                case "DistributionCenter": return new DistributionCenter(name);
                case "Warehouse": return new Warehouse(name);
                default: throw new InvalidOperationException("Invalid storage type!");
            }
        }
    }
}