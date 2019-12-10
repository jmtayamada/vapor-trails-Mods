using UnityEngine;
using System.Collections.Generic;

public class ChestRotator : MonoBehaviour {
    public int skinNum;
    public int spriteIndex;
    [SerializeField]
    public List<ChestSprites> skins;

    int skinLastFrame;
    int indexLastFrame;
    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update() {
        if (skinLastFrame != skinNum || indexLastFrame != spriteIndex) {
            spriteRenderer.sprite = skins[skinNum].sprites[spriteIndex];
        }
        skinLastFrame = skinNum;
        indexLastFrame = spriteIndex;
    }
}

[System.Serializable]
public class ChestSprites {
    public List<Sprite> sprites;
}