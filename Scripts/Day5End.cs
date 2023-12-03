using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day5End : MonoBehaviour
{
    public GameObject playbtn;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ActivatePlayBtnAfterDelay(10f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator ActivatePlayBtnAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        playbtn.SetActive(true);
    }
}
