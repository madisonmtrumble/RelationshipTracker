using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class MT_SocialSystem : MonoBehaviour
{
    public int shopKeepRelations;
    public int NPC1Relations;
    public int NPC2Relations;

    public int NumTalkedNPC1;
    public int NumTalkedNPC2;
    public int NumTalkedShopKeep;

    public Text TalkingText;
    public Text NPC1RelationText;
    public Text NPC2RelationText;
    public Text ShopKeepRelationText;
    void Start()
    {
        shopKeepRelations = 0;
        NPC1Relations = 0;
        NPC2Relations = 0;

        shopKeepRelations = 0;
        NPC1Relations = 0;
        NPC2Relations = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        while (other.gameObject.CompareTag("NPC1"))
        {
            if (NumTalkedNPC1 == 0)
            {
                //Debug.Log("Collision");
                TalkingText.text = "Speaking to NPC1...";
                NPC1Relations++;
                NumTalkedNPC1++;
                break;
            }
            else if (NumTalkedNPC1 == 1)
            {
                //Debug.Log("Collision");
                TalkingText.text = "Speaking to NPC1...";
                NPC1Relations++;
                NumTalkedNPC1++;
                break;
            }
            else if (NumTalkedNPC1 == 2)
            {
                //Debug.Log("Collision");
                TalkingText.text = "You've already spoken to NPC1 twice today.";
                NumTalkedNPC1++;
                break;
            }
            else if (NumTalkedNPC1 == 3)
            {
                TalkingText.text = "You're being a nuisance.";
                NPC1Relations--;
                break;
            }
            else if (NumTalkedNPC1 > 4)
                continue;
        }

        while (other.gameObject.CompareTag("NPC2"))
        {
            if (NumTalkedNPC2 == 0)
            {
                //Debug.Log("Collision");
                TalkingText.text = "Speaking to NPC2...";
                NPC2Relations++;
                NumTalkedNPC2++;
                break;
            }
            else if (NumTalkedNPC2 == 1)
            {
                //Debug.Log("Collision");
                TalkingText.text = "Speaking to NPC2...";
                NPC2Relations++;
                NumTalkedNPC2++;
                break;
            }
            else if (NumTalkedNPC2 == 2)
            {
                //Debug.Log("Collision");
                TalkingText.text = "You've already spoken to NPC2 twice today.";
                NumTalkedNPC2++;
                break;
            }
            else if (NumTalkedNPC2 == 3)
            {
                TalkingText.text = "You're being a nuisance.";
                NPC2Relations--;
                break;
            }
            else if (NumTalkedNPC2 > 4)
                continue;
        }

        while (other.gameObject.CompareTag("ShopKeep"))
        {
            if (NumTalkedShopKeep == 0)
            {
                //Debug.Log("Collision");
                TalkingText.text = "Speaking to Shopkeep...";
                shopKeepRelations++;
                NumTalkedShopKeep++;
                break;
            }
            else if (NumTalkedShopKeep == 1)
            {
                //Debug.Log("Collision");
                TalkingText.text = "Speaking to Shopkeep...";
                shopKeepRelations++;
                NumTalkedShopKeep++;
                break;
            }
            else if (NumTalkedShopKeep == 2)
            {
                //Debug.Log("Collision");
                TalkingText.text = "You've already spoken to the Shopkeep twice today.";
                NumTalkedShopKeep++;
                break;
            }
            else if (NumTalkedShopKeep == 3)
            {
                TalkingText.text = "You're being a nuisance.";
                shopKeepRelations--;
                break;
            }
            else if (NumTalkedShopKeep > 4)
                continue;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        TalkingText.text = "";
    }
    void Update()
    {
        //tracking npc1 relations and updating level
        if(NPC1Relations == 0)
        {
            NPC1RelationText.text = "NPC1\nRelationship Level: 0"; 
        }
        else if(NPC1Relations == 1)
        {
            NPC1RelationText.text = "NPC1\nRelationship Level: 0"; 
        }
        else if(NPC1Relations == 2)
        {
            NPC1RelationText.text = "NPC1\nRelationship Level: 1";
        }

        //tracking NPC2 relations and updating level
        if (NPC2Relations == 0)
        {
            NPC2RelationText.text = "NPC2\nRelationship Level: 0"; 
        }
        else if (NPC2Relations == 1)
        {
            NPC2RelationText.text = "NPC2\nRelationship Level: 0"; 
        }
        else if (NPC2Relations == 2)
        {
            NPC2RelationText.text = "NPC2\nRelationship Level: 1";
        }

        //tracking shop keep relationship and updating level
        if (shopKeepRelations == 0)
        {
            ShopKeepRelationText.text = "Shopkeep\nRelationship Level: 0"; 
        }
        else if (shopKeepRelations == 1)
        {
            ShopKeepRelationText.text = "Shopkeep\nRelationship Level: 0"; 
        }
        else if (shopKeepRelations == 2)
        {
            ShopKeepRelationText.text = "Shopkeep\nRelationship Level: 1";
        }
    }
}
