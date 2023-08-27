using UnityEngine;

namespace ObserverPattern
{
    public class Player : MonoBehaviour
    {
        Enemy enemy;
        void Start()
        {
            enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy>();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) //You should use new Input System.
            {
                if (enemy.hp.Value < 10) return;

                enemy.hp.Value -= 10;
            }
        }
    }
}