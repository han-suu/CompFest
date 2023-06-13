using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [Header("Time UI")]
    [SerializeField] private GameObject DayPanel;
    [SerializeField] private GameObject NightPanel;

    public bool isDay, isNight;
    public int Day;
    // Start is called before the first frame update
    private static TimeManager instance;
    //private PlayerInput playerInput;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Time Manager in the scene");
        }
        instance = this;
    }

    public static TimeManager GetInstance()
    {
        return instance;
    }
    void Start()
    {
        Day = 1;
        isDay = true;
        StartCoroutine(StartNight());
    }

    // Update is called once per frame
    void Update()
    {
        if (isDay)
        {
            DayPanel.SetActive(true);
            NightPanel.SetActive(false);
        }
        else
        {
            NightPanel.SetActive(true);
            DayPanel.SetActive(false);
        }
    }

    private IEnumerator StartDay()
    {
<<<<<<< Updated upstream
        yield return new WaitForSeconds(5f);
=======
        yield return new WaitForSeconds(10f);
>>>>>>> Stashed changes
        isNight = false;
        isDay = true;
        Debug.Log("Sekarang Siang");
        StartCoroutine(StartNight());
        //NightPanel.SetActive(false);
        //DayPanel.SetActive(true);
        Day+=1;
        // Debug.Log(Day);

    }

    private IEnumerator StartNight()
    {
<<<<<<< Updated upstream
        yield return new WaitForSeconds(5f);
=======
        yield return new WaitForSeconds(10f);
>>>>>>> Stashed changes

        isDay = false;
        isNight = true;
        Debug.Log("Sekarang Malam");
        StartCoroutine(StartDay());
        //NightPanel.SetActive(true);
        //DayPanel.SetActive(false);
    }

    
}
