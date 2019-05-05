﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodBar : MonoBehaviour
{
    public Slider foodbar;
    public float Current { get; set; }
    public float Max { get; set; }
    public float increment;
    public GameObject Win;

    // Start is called before the first frame update
    void Start()
    {
        Max = 500f;
        increment = 50f;
        Current = 0;
        foodbar.value = CalculateFood();
        
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            UpdateFoodBar();
        }
    }

    float CalculateFood()
    {
        return Current / Max;
    }

    public void UpdateFoodBar()
    {
        if(Current + increment >= Max)
        {
            Time.timeScale = 0;
            Win.SetActive(true);
        } else
        {
            Current += increment;
            foodbar.value = CalculateFood();
        }
    }
    public void IncreaseFoodBar()
    {
        Current += 1000;
        foodbar.value = Current / Max;
    }
}
