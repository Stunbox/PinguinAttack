using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float WaitingTimeForPressEnter;
    [SerializeField] private UI_Manager uI_Manager;
    [SerializeField] private GameObject player;
    private bool CanEnter = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForAnimation(WaitingTimeForPressEnter));
    }

    // Update is called once per frame
    void Update()
    {
        if (CanEnter) { CheckifEnter(); }
    }
    void CheckifEnter()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            uI_Manager.RemoveUIMenu();
            player.SetActive(true);
            CanEnter = false;
            Cursor.visible = false;
            //Debug.Log("PResionaste enter");
        }
    }
    IEnumerator WaitForAnimation(float time)
    {
        yield return new WaitForSeconds(time);
        CanEnter = true;
    }
}
