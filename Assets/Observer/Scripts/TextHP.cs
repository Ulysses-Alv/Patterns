using TMPro;
using UniRx;
using UnityEngine;

namespace ObserverPattern
{
    public class TextHP : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI textMeshPro;
        private void Awake()
        {
            GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy>().hp.Subscribe(UpdateText);
        }
        void UpdateText(int health)
        {
            textMeshPro.text = health.ToString();
        }
    }
}