using System.Collections.Generic;
using System;
using UnityEngine;

namespace FactoryPattern
{
    [CreateAssetMenu(menuName = "Custom/Factory configuration")]
    public class FactoryConfiguration : ScriptableObject
    {
        [SerializeField] private ObjectExample[] objectsExamples;
        private Dictionary<string, ObjectExample> idToObj;
        public List<string> ids;

        private void Awake()
        {
            idToObj = new Dictionary<string, ObjectExample>(objectsExamples.Length);

            foreach (var objEx in objectsExamples)
            {
                idToObj.Add(objEx.Id, objEx);
                ids.Add(objEx.Id);
            }
        }
        public ObjectExample GetObjectPrefabById(string id)
        {
            if (!idToObj.TryGetValue(id, out var objEx))
            {
                throw new Exception($"{id} Doesn't exist");
            }
            return objEx;
        }
    }
}