using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

using System.IO.Ports;

public class Truco : MonoBehaviour
{
   // string strBufferIn;
 //   string strBufferOut;

    Dropdown ddpuertos = gameObject.getComponent(typeof(Dropdown)) as Dropdown;
    HingeJoint hingeJoint;

    void configurar()
    {
         // System.IO.Ports.SerialPort puerto1;
         // System.IO.Ports.SerialPort puerto2;
    }

    public void btnBuscarPuertos_click()
    {
        string[] PuertosDisponibles = SerialPort.GetPortNames();

        List<string> puertos = new List<string>();
        puertos = PuertosDisponibles.OfType<string>().ToList();

        ddpuertos.AddOptions(puertos);

        print("puerto " + PuertosDisponibles[0]);
    }

    // Start is called before the first frame update
    void Start()
    {
       // strBufferIn = "";
       // strBufferOut = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
