using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayGame : MonoBehaviour
{


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(false);
        }

    }
}
