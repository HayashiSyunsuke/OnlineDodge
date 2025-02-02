using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giganteenAnim : MonoBehaviour
{
    private Animator anim;
    float animTimer;
    int rand;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        rand = Random.Range(1, 4);
    }

    // Update is called once per frame
    void Update()
    {
        // 回転しないようにする
        //this.transform.rotation = Quaternion.Euler(0, 90, 0);

        animTimer += Time.deltaTime;

        if (animTimer < 5.0f)
            return;

        rand = Random.Range(1, 4);

        animTimer = 0;

        if (rand == 1)
        {
            anim.SetBool("clap", true);
            anim.SetBool("yell", false); ;
            anim.SetBool("talk", false);
        }

        if (rand == 2)
        {
            anim.SetBool("yell", true);
            anim.SetBool("clap", false);
            anim.SetBool("talk", false);
        }

        if (rand == 3)
        {
            anim.SetBool("talk", true);
            anim.SetBool("clap", false);
            anim.SetBool("yell", false); ;
        }
    }
}
