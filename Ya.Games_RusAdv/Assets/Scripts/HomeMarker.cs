using TMPro;
using UnityEngine;

public class HomeMarker : MonoBehaviour
{
    public TextMeshProUGUI _textMesh;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        _textMesh.text = "Нажми 'Е'";

    }

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Pressed E");

            gameObject.SetActive(false);
            _textMesh.text = "Отлично! Сюжетная линия пройдена! Можешь погулять, посмотреть окресности!";
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited");
        _textMesh.text = "Всё! Направляйся домой! Наслаждайся двором!";
    }
}
