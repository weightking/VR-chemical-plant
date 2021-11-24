using UnityEngine;
using UnityEngine.UI;
using System.Reflection;

public class GetFlowRateFI5 : MonoBehaviour
{
    Text text_timeSpend;
    float angleCV86;
    void Start()
    {
        text_timeSpend = GetComponent<Text>();
    }
    double flowRate = 0.0d;
    double FullflowRate = 1.0d;
    void Update()
    {
        angleCV86 = GetInspectorRotationValueMethod(GameObject.Find("valveCV86").transform);
        flowRate = FullflowRate * (angleCV86 - 90.0) / 177.0;
        if (flowRate < 0)
        {
            flowRate = 0;
        }
        text_timeSpend.text = string.Format("FI5:{0:f2}(L/min)", flowRate);
    }
    public static float GetInspectorRotationValueMethod(Transform transform)
    {
        // 获取原生值
        System.Type transformType = transform.GetType();
        PropertyInfo m_propertyInfo_rotationOrder = transformType.GetProperty("rotationOrder", BindingFlags.Instance | BindingFlags.NonPublic);
        object m_OldRotationOrder = m_propertyInfo_rotationOrder.GetValue(transform, null);
        MethodInfo m_methodInfo_GetLocalEulerAngles = transformType.GetMethod("GetLocalEulerAngles", BindingFlags.Instance | BindingFlags.NonPublic);
        object value = m_methodInfo_GetLocalEulerAngles.Invoke(transform, new object[] { m_OldRotationOrder });
        string temp = value.ToString();
        //将字符串第一个和最后一个去掉
        temp = temp.Remove(0, 1);
        temp = temp.Remove(temp.Length - 1, 1);
        //用‘，’号分割
        string[] tempVector3;
        tempVector3 = temp.Split(',');
        //将分割好的数据传给Vector3
        Vector3 vector3 = new Vector3(float.Parse(tempVector3[0]), float.Parse(tempVector3[1]), float.Parse(tempVector3[2]));
        return vector3.x;
    }
}
