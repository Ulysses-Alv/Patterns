using System.Collections.Generic;
using UnityEngine;

namespace ObjectPoolingPattern
{
    public static class ObjectPooling
    {

        static Dictionary<int, Queue<GameObject>> pool = new Dictionary<int, Queue<GameObject>>();
        static Dictionary<int, GameObject> parentsGOs = new Dictionary<int, GameObject>();

        public static void PreLoad(GameObject objectToPool, int amount)
        {
            int id = objectToPool.GetInstanceID();

            GameObject parent = new GameObject
            {
                name = objectToPool.name + " Pool"
            };
            parentsGOs.Add(id, parent);

            pool.Add(id, new Queue<GameObject>());

            for (int i = 0; i < amount; i++)
            {
                CreateObject(objectToPool);
            }
        }

        private static void CreateObject(GameObject objectToPool)
        {
            int id = objectToPool.GetInstanceID();

            GameObject go = Object.Instantiate(objectToPool);
            go.transform.SetParent(GetParent(id).transform);
            go.SetActive(false);

            pool[id].Enqueue(go);
        }

        private static GameObject GetParent(int parentID)
        {
            parentsGOs.TryGetValue(parentID, out GameObject parent);

            return parent;
        }

        public static GameObject GetObject(GameObject objectToPool)
        {

            int id = objectToPool.GetInstanceID();

            if (pool[id].Count == 0)
            {
                CreateObject(objectToPool);
            }

            GameObject go = pool[id].Dequeue();
            go.SetActive(true);
            return go;

        }

        public static void RecicleObject(GameObject objectToPool, GameObject objectToRecicle)
        {
            int id = objectToPool.GetInstanceID();

            pool[id].Enqueue(objectToRecicle);
            objectToRecicle.SetActive(false);

        }

    }
}