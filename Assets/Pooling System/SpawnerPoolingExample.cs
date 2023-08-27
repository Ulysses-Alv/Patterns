using System.Collections;
using UnityEngine;

namespace ObjectPoolingPattern.Vlyx
{
    public class SpawnerPoolingExample : MonoBehaviour
    {
        [SerializeField] GameObject cube;
        [SerializeField] GameObject sphere;

        void Start()
        {
            ObjectPooling.PreLoad(cube, 5);
            ObjectPooling.PreLoad(sphere, 5);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Vector3 vector = SpawnPosition();

                GameObject c = ObjectPooling.GetObject(cube);
                c.transform.position = vector;
                StartCoroutine(DeSpawn(cube, c, 2.0f));
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                Vector3 vector = SpawnPosition();

                GameObject s = ObjectPooling.GetObject(sphere);
                s.transform.position = vector;
                StartCoroutine(DeSpawn(sphere, s, 2.0f));
            }
        }


        Vector3 SpawnPosition()
        {
            float x = Random.Range(-10.0f, 10.0f);
            float y = 0.5f;
            float z = Random.Range(-10.0f, 10.0f);

            Vector3 vector = new Vector3(x, y, z);

            return vector;
        }

        IEnumerator DeSpawn(GameObject primitive, GameObject go, float time) //you need the primitive and the GO.
        {
            yield return new WaitForSeconds(time);
            ObjectPooling.RecicleObject(primitive, go);
        }
    }
}