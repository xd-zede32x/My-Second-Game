using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform plaers;
    public Text _text;

    private void Update()
    {
        _text.text = plaers.position.z.ToString("0");
    }
}
