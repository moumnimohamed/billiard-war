using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knob : MonoBehaviour {

   //القالب المستخدم لرسم النقاط
    public GameObject pathPointPrefab;

    //المسافة بين كل نقطتين متتابعتين
    public float pointDistance = 0.75f;

    //الكائن الأب لكائنات نقاط المسار
    Transform pathParent;

    //متغير لتخزين موقع آخر نقطة تمت إضافتها
    Vector2 lastPointPosition;

    //متغير داخلي لمعرفة ما إذا كان المقذوف قد تم إطلاقه أم لا

	   //تستدعى مرة واحدة عند بداية التشغيل
	   void Start () {
	       //Path ابحث عن الكائن الأب لنقاط المسار والمسمى
        pathParent = GameObject.Find("knob_pos").transform;
	   }
	
	   //تستدعى مرة عند تصيير كل إطار
	   void Update () {
      
            float dist = Vector2.Distance(transform.position, lastPointPosition);
            if (dist >= pointDistance)
            {
                //حان الوقت للإضافة نقطة جديدة
                AddPathPoint();
            }
        
	   }

    void ProjectileLaunched()
    {
        //تم إطلاق المقذوف للتو لذا احذف المسار السابق
        for (int i = 0; i < pathParent.childCount; i++)
        {
            Destroy(pathParent.GetChild(i).gameObject);
        }

        AddPathPoint();

        //قم بتحديث قيمة المتغير حيث أن المقذوف قد تم إطلاقه
       
    }

    //تقوم بإضافة نقطة جديدة للمسار
    void AddPathPoint()
    {
        //قم بإنشاء نقطة جديدة مستخدما القالب
        GameObject newPoint = (GameObject)Instantiate(pathPointPrefab);
        //قم بوضع النقطة في الموقع الحالي للمقذوف
        newPoint.transform.position = transform.position;
        //قم بضبط الكائن الأب للنقطة
        newPoint.transform.parent = pathParent;
        //قم بتخزين موقع النقطة التي تمت إضافتها
        lastPointPosition = transform.position;
    }
}