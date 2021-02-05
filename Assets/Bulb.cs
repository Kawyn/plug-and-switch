﻿using UnityEngine;

public class Bulb : MonoBehaviour
{
    public Sprite[] sprites;
    
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }



    public void Power(Arguments args)
    {
        spriteRenderer.sprite = sprites[args.off ? 0 : 1];
    }
}
