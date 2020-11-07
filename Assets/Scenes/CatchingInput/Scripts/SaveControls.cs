using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveControls
{
    public static void SaveControlsInput(ControlsInput controls)
    {
        //Debug.Log("SaveControlsInput" + controls.m_Action);

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/controls.cfg";
        FileStream stream = new FileStream(path, FileMode.Create);

        ControlsData data = new ControlsData(controls);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static ControlsData LoadControls()
    {
        string path = Application.persistentDataPath + "/controls.cfg";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            ControlsData data = formatter.Deserialize(stream) as ControlsData;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("Save file not found: " + path);
            return null;
        }
    }
}
