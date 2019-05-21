using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// UI
// namespace
// Component Menu

public class Health : MonoBehaviour
{   // Players maximum health
    public float maxHealth;
    // Players current health
    public float curHealth;
    // Players delay health drop
    public float delayHealth;
    [Header("Delay Drop Speed")]
    // Speed that delay health drops at
    public float speed;
    [Header("Reference for UI elements")]
    // Reference to slider
    public Slider healthSlider;
    // Reference to fill
    public Image healthFill;
    // Reference to Delay Slider
    public Slider delaySlider;
    // Reference to Delay Fill
    public Image delayFill;

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = Mathf.Clamp01(curHealth / maxHealth);
        if(delayHealth > curHealth)
        {
            delayHealth -= Time.deltaTime * speed;
        }
        delaySlider.value = Mathf.Clamp01(delayHealth / maxHealth);
        ManageHealthBar();
    }
    void ManageHealthBar()
    {
        if (curHealth <= 0 && healthFill.enabled)
        {
            healthFill.enabled = false;
        }
        else if (!healthFill.enabled)
        {

        }
    }
    //HealthManager()
    // Control the display of the current health fill
    // - off and on
    // Control the display of the delay health fill
    // - off
    // - on ... set delay value to current health
    // - on ... set slider to current health
}


// Player health max and current and delay

// Dropspeed
// Delay slider , current health slider
// Delay fill, current fill

// Two sliders same setup
// Backround Slider as normal then duplicate
// parent this duplicate to the original slider

// Setting of current health value on slider
// if delay health is bigger than our current health
// Over time according to our speed make delay health match the current health
// Setting the delay value on the slider
// HealthManager()