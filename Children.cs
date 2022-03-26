using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Children : MonoBehaviour
{
   private Vector2 pos;
public int Player;
   public int children = 999;
   int num = 0;
   int num_em = 0;
   string name_;

    void Start()
    {
        //name_ = gameObject.name;
        
    }
    //получать для каждогог игрока отдельно кординаты и отправлять в children
    //1.получаем координаты из таблицы мира в виде x_y:x_y:x_y:x_y:0
    //2.присвоение координат каждому объекту player1_1 player1_2p

    void Set_Coordinates_For_Children()
    {
        StartCoroutine(Get_Coordinates());
        //добавил координаты каждому дочернему объекту
    }
    
    private IEnumerator Get_Coordinates()//получил координаты player 
    {
        WWWForm form = new WWWForm();
         float x = 0;
         float y = 0;
        form.AddField("Child", children);
        form.AddField("Player", Player);
        x += 0.001f;
        
        
        y+=0.001f;
        int num = 6;
        string answer = x.ToString()+"_"+y.ToString()+"_";
        //WWW www = new WWW("http://doublenikmak.ru/Cpu.php", form);

        //yield return www;
        //if (www.error != null)
        //{
        //    Debug.Log("Error" + www.error);
        //    yield break;
        //}
        //else
        //{
        //   if(www.text != "false")
        //    {
                string[] sub;
                //string answer = www.text;
                sub = answer.Split('_');//x_y

                float x_ = float.Parse(sub[0]);
                float y_ = float.Parse(sub[1]);
                Vector2 pos = new Vector2(x_, y_);
        //    }
            yield break;
       // }
    }


    void Update()
    {

        Set_Coordinates_For_Children();

        Vector2 start = new Vector2(transform.position.x, transform.position.y);
        transform.position = Vector3.Lerp(start, pos, Time.time);
        
        //получить его координаты
    }
}
