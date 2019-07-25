using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataInserter : MonoBehaviour
{
    public string inputName;
    public string inputMail;

    string CreateUserURL= "https://databasechroma.000webhostapp.com/itemsData.php";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CreateUser(inputName, inputMail);
            Debug.Log("datos subidos correctamente");
        }
    }
    public void CreateUser(string username, string mail)
    {
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", username);
        form.AddField("MailPost",mail);

        WWW www = new WWW(CreateUserURL, form);
    }
}
