using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Details : MonoBehaviour
{

    public Text Title1;
    public Text Title2;


    public Text textTitleNama;
    public Text textPenyebab;
    public Text textPenanganan;
    public Image gambar;


    // Start is called before the first frame update
    void Start()
    {
        // Get the selected dental issue ID from PlayerPrefs (assuming "Desc" is the correct key)
        int selectedIssueID = PlayerPrefs.GetInt("Desc", 1); // Default to issue 1 if not found

        // Load the dental issue based on the selected ID
        DentalIssue selectedIssue = GetDentalIssueByID(selectedIssueID);

        if (selectedIssue != null && selectedIssue.id != 1)
        {
            // Update the UI elements with the details of the selected dental issue
            textTitleNama.text = selectedIssue.nama;
            textPenyebab.text = selectedIssue.penyebab;
            textPenanganan.text = selectedIssue.penanganan;
            gambar.sprite = selectedIssue.image;
        }else if(selectedIssue.id == 1)
        {
          textTitleNama.text = selectedIssue.nama;
          gambar.sprite = selectedIssue.image;
          Title1.text = "Tips untuk Mencegah Karies pada Gigi Anak";
          textPenyebab.text = selectedIssue.penyebab;
          textPenanganan.text = selectedIssue.penanganan;
          Title2.text = "Cara Mendidik Anak agar Menjaga Kesehatan Gigi";


        }
    }

    // Function to find a dental issue by ID in the issues list
    private DentalIssue GetDentalIssueByID(int issueID)
    {
        // Retrieve the DentalIssuesDatabase script from the scene (make sure it's attached to a GameObject)
        DentalIssuesDatabase database = FindObjectOfType<DentalIssuesDatabase>();

        if (database != null)
        {
            foreach (DentalIssue issue in database.issues)
            {
                if (issue.id == issueID)
                {
                    return issue;
                }
            }
        }

        return null; // Return null if the issue is not found
    }
}
