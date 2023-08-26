using System.Collections;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    private ObjectFactory objectFactory;

    [SerializeField] private FactoryConfiguration factoryConfiguration;
    [SerializeField] private GameObject idOne;
    [SerializeField] private GameObject idTwo;
    [SerializeField] private GameObject idThree;

    private void Awake()
    {
        objectFactory = new ObjectFactory(Instantiate(factoryConfiguration));
    }

    #region Example
    private void Start()
    {
        idOne = objectFactory.GetObjectExample("IdOne").gameObject;
        idTwo = objectFactory.GetObjectExample("IdTwo").gameObject;
        idThree = objectFactory.GetObjectExample("IdThree").gameObject;

        //Factoy Method + Object Pooling.
        ObjectPooling.PreLoad(idOne, 2);
        ObjectPooling.PreLoad(idTwo, 2);
        ObjectPooling.PreLoad(idThree, 2);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Vector3 vector = SpawnPosition();

            GameObject idOneGO = ObjectPooling.GetObject(idOne);
            idOneGO.transform.position = vector;
            StartCoroutine(DeSpawn(idOne, idOneGO, RandomTime()));
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 vector = SpawnPosition();

            GameObject idTwoGO = ObjectPooling.GetObject(idTwo);
            idTwoGO.transform.position = vector;
            StartCoroutine(DeSpawn(idTwo, idTwoGO, RandomTime()));
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Vector3 vector = SpawnPosition();

            GameObject idThreeGO = ObjectPooling.GetObject(idThree);
            idThreeGO.transform.position = vector;
            StartCoroutine(DeSpawn(idThree, idThreeGO, RandomTime()));
        }
    }

    private float RandomTime()
    {
        return Random.Range(0.1f, 1f);
    }
    Vector3 SpawnPosition()
    {
        float x = Random.Range(-5.0f, 5.0f);
        float y = 2f;
        float z = Random.Range(-5.0f, 5.0f);

        Vector3 vector = new Vector3(x, y, z);

        return vector;
    }

    IEnumerator DeSpawn(GameObject primitive, GameObject go, float time)
    {
        yield return new WaitForSeconds(time);
        ObjectPooling.RecicleObject(primitive, go);
    }


    #endregion
}
