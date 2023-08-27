using UnityEngine;

namespace FactoryPattern
{
    public class ObjectFactory
    {
        public readonly FactoryConfiguration factoryConfiguration;

        public ObjectFactory(FactoryConfiguration powerUpsConfiguration)
        {
            this.factoryConfiguration = powerUpsConfiguration;
        }

        public ObjectExample CreatePrefab(string id)
        {
            ObjectExample prefab = factoryConfiguration.GetObjectPrefabById(id);

            return Object.Instantiate(prefab);
        }
        public ObjectExample GetObjectExample(string id)
        {
            return factoryConfiguration.GetObjectPrefabById(id);
        }
    }
}
