using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MsgPanelHandler : MonoBehaviour
{
    #region //config
    private const string TextTitleName = "ImageTitle";
    private const string TextContexName = "TextContex";
    private const string ButtonYesName = "BtnYes";
    private const string ButtonNoName = "BtnNo";
    #endregion

    #region //變數
    private Text TextTitle { get; set; }
    private Text TextContent { get; set; }
    private Button ButtonYes { get; set; }
    private Button ButtonNo { get; set; }
    #endregion

    void Awake()
    {
        ScanObject();
    }

    #region //對外接口
    public string Title
    {
        get { return TextTitle.text; }
        set
        {
            if (TextTitle != null)
            {
                TextTitle.text = value;
            }
        }
    }

    public string Content
    {
        get { return TextContent.text; }
        set
        {
            if (TextContent != null)
            {
                TextContent.text = value;
            }
        }
    }

    public string YesText
    {
        get { return ButtonYes.GetComponentInChildren<Text>().text; }
        set
        {
            if (ButtonYes != null)
            {
                ButtonYes.GetComponentInChildren<Text>().text = value;
            }
        }
    }

    public string NoText
    {
        get { return ButtonNo.GetComponentInChildren<Text>().text; }
        set
        {
            if (ButtonNo != null)
            {
                ButtonNo.GetComponentInChildren<Text>().text = value;
            }
        }
    }
    #endregion

    private void ScanObject()
    {
        try
        {
            int childCount = this.transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                switch (transform.GetChild(i).gameObject.name)
                {
                    case TextTitleName:
                        TextTitle = transform.GetChild(i).GetComponentInChildren<Text>();
                        break;
                    case TextContexName:
                        TextContent = transform.GetChild(i).GetComponent<Text>();
                        break;
                    case ButtonYesName:
                        ButtonYes = transform.GetChild(i).GetComponent<Button>();
                        break;
                    case ButtonNoName:
                        ButtonNo = transform.GetChild(i).GetComponent<Button>();
                        break;
                }
            }
        }
        catch (Exception exp)
        {
            Debug.LogError(exp.ToString());
            throw;  //拋到上一層
        }
    }
}
