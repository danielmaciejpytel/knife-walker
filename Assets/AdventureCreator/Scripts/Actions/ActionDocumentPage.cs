/*
 *
 *	Adventure Creator
 *	by Chris Burton, 2013-2026
 *	
 *	"ActionDocumentPage.cs"
 * 
 *	This action makes a Document active for display in a Menu.
 * 
 */

using UnityEngine;
using System.Collections.Generic;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace AC
{

	[System.Serializable]
	public class ActionDocumentPage : Action, IDocumentReferencerAction
	{

		public int documentID;

		public int pageIndex;
		public bool isVisible;
		
		
		public override ActionCategory Category { get { return ActionCategory.Document; }}
		public override string Title { get { return "Set page visibility"; }}
		public override string Description { get { return "Sets the visibility of a specific Document page."; }}


		public override float Run ()
		{
			DocumentInstance documentInstance = KickStarter.runtimeDocuments.GetCollectedDocumentInstance (documentID);
			
			if (documentInstance == null)
			{
				LogWarning("Document " + documentID + " is not in the Player's current collection");
				return 0f;
			}
			
			if (isVisible)
			{
				documentInstance.HiddenIndices.Remove(pageIndex);
				if (documentInstance.lastOpenPage > pageIndex)
				{
					documentInstance.lastOpenPage = Mathf.Min(documentInstance.lastOpenPage + 1, documentInstance.GetVisiblePages().Count - 1);
				}
			}
			else
			{
				documentInstance.HiddenIndices.Add(pageIndex);
				if (documentInstance.lastOpenPage > pageIndex)
				{
					documentInstance.lastOpenPage = Mathf.Max(documentInstance.lastOpenPage - 1, 1);
				}
			}
			
			
			isRunning = false;
			return 0f;
		}


		#if UNITY_EDITOR

		public override void ShowGUI (List<ActionParameter> parameters)
		{
			documentID = InventoryManager.DocumentSelectorList (documentID, "Document");
			pageIndex = EditorGUILayout.IntField("Page index:", pageIndex);
			isVisible = EditorGUILayout.Toggle("Make visible?", isVisible);
		}


		public override string SetLabel ()
		{
			Document document = KickStarter.inventoryManager.GetDocument (documentID);
			if (document != null)
			{
				return document.Title;
			}
			return string.Empty;
		}


		public int GetNumDocumentReferences (int _docID, List<ActionParameter> parameters)
		{
			if (documentID == _docID)
			{
				return 1;
			}
			return 0;
		}


		public int UpdateDocumentReferences (int oldDocumentID, int newDocumentID, List<ActionParameter> actionParameters)
		{
			if (documentID == oldDocumentID)
			{
				documentID = newDocumentID;
				return 1;
			}
			return 0;
		}

		#endif


		/**
		 * <summary>Creates a new instance of the 'Document: Set page visibility' Action</summary>
		 * <param name = "documentID">The ID number of the document to open</param>
		 * <param name = "pageIndex">The index of the page to affect</param>
		 * <param name = "isVisible">If True, the page will be made visible.  If false, invisible</param>
		 * <returns>The generated Action</returns>
		 */
		public static ActionDocumentPage CreateNew (int documentID, int pageIndex, bool isVisible)
		{
			ActionDocumentPage newAction = CreateNew<ActionDocumentPage> ();
			newAction.documentID = documentID;
			newAction.pageIndex = pageIndex;
			newAction.isVisible = isVisible;
			return newAction;
		}
		
	}

}