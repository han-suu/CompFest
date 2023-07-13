﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class PlayerHealth : MonoBehaviour
{
	PlayerInputAction InputActions;

	public int maxHealth = 100;
	public int currentHealth;

	public HealthBar healthBar;
    [SerializeField] TextMeshProUGUI TextMaxHealthUI;
    [SerializeField] TextMeshProUGUI TextHealthUI;

    void Awake()
    {
        InputActions = new PlayerInputAction();
    }
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 100;
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
        SetUIMaxHP(maxHealth);
        SetUIHP(currentHealth);
        //InputActions.Player.Damage.performed += HandleDamage =>
        //{
        //    Debug.Log("ADUH");
        //    TakeDamage(20);
            
        //};
    }


    private void OnEnable()
    {
        InputActions.Player.Damage.Enable();
    }

    private void OnDisable()
    {

        InputActions.Player.Damage.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth < 1)
        {
            Debug.Log(TimeManager.Day);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

	public void TakeDamage(int damage)
	{
        Debug.Log("ADUH");
        currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
        SetUIHP(currentHealth);
	}

    public void SetUIMaxHP(int health){
        TextMaxHealthUI.text = health.ToString ();
    }
    public void SetUIHP(int health){
        TextHealthUI.text = health.ToString ();
    }
}
