using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ship1_change : MonoBehaviour
{


    TMP_Text myMoney;
    public int count = 0;
    public AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hell");
        myMoney = GameObject.Find("Money").GetComponent<TextMeshProUGUI>();
        myMoney.text = "$ " + count;
    }

    // Update is called once per frame
    void Update()
    {
        myMoney.text = "$ " + count;
    }

    void OnTriggerEnter(Collider other)
    { // select 됐을 때
        Debug.Log("trigger");
        if (other.tag == "fish")
        {

            count += 100;
            Debug.Log(count);
            other.gameObject.SetActive(false); //아이템 비활성화 
            audioSource.Play();

        }
        if (count == 200)
        {
            count = 0;
            ship2Scene_change();
        }

    }

    void ship2Scene_change()
    {
        SceneManager.LoadScene("2ship_scene");
    }

}