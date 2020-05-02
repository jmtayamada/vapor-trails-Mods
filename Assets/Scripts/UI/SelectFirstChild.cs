using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SelectFirstChild : MonoBehaviour {
    void Start() {
        StartCoroutine(SelectChild());
    }

    IEnumerator SelectChild() {
        yield return new WaitForEndOfFrame();
        Button b = GetComponentInChildren<Button>();
        b.Select();
        b.OnSelect(null);
    }
}