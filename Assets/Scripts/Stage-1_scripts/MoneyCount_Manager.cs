//์ฌาF}UL
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyCount_Manager : MonoBehaviour
{
    public TextMeshProUGUI money;
    //public TextMeshProUGUI moneyCount;
    private int count;

    [SerializeField] Money_counter cp;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        //Debug
        if (Input.GetKey(KeyCode.Space)) { count += 1; }
        moneyCount.text = "" + count;
        money.text = "count%100 : " + (count % 100) + "~"+"    count/100 : "+(count/100)+"~";
        */
        count = cp.metaobject - 22;

        //9900~ศบฬอ็Pสล\ฆBcountช99
        //9900ญศบฬอญฦ็Pสล\ฆBcountช999999
        if (count == 0) { money.text = count + "~"; }
        else if (count > 0 && count <= 99) { money.text = count + "00~"; }
        else if (count > 99 && count <= 999999) { money.text = (count / 100) + "ญ" + (count % 100) + "00~"; }
    }
}
