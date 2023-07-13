using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
	PlayerInputAction InputActions;

	public int maxHealth = 100;
	public int currentHealth;

	public HealthBar healthBar;
<<<<<<< Updated upstream
=======
    [SerializeField] public TextMeshProUGUI TextMaxHealthUI;
    [SerializeField] TextMeshProUGUI TextHealthUI;
    [SerializeField] TimeManager TimeM;
>>>>>>> Stashed changes

    void Awake()
    {
        InputActions = new PlayerInputAction();
    }
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< Updated upstream
        maxHealth = 130;
=======
        maxHealth = 100;
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======
            Debug.Log(TimeM.Day);
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
    public void kutuk(){
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(currentHealth);
    }

    // public void Healing(){
    //     // currentHealth += heal;

	// 	healthBar.SetMaxHealth(currentHealth);
    // }
=======
    public void SetUIMaxHP(int health){
        TextMaxHealthUI.text = health.ToString ();
    }
    public void SetUIHP(int health){
        TextHealthUI.text = health.ToString ();
    }
>>>>>>> Stashed changes
}
