using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateBase
{
    class CompleteForm
    {
        #region CreatingObjectForm
        static public void dgvExistingUsers(CreatingObjectForm form)
        {
            form.dgvExistingUsers.DataSource = (from user in Control.container.Users select 
                new { user.Id, user.Name }).ToList();
            form.dgvExistingUsers.Columns[0].Visible = false;
            if (form.dgvExistingUsers.Rows.Count != 0)
                form.dgvExistingUsers[1, 0].Selected = true;
            form.dgvExistingUsers.Update();
        }

        static public void dgvExistingCollections(CreatingObjectForm form)
        {
            form.dgvExistingCollections.DataSource = (from collection in Control.currentUser.Collections select
                new { collection.Id, collection.Name }).ToList();
            form.dgvExistingCollections.Columns[0].Visible = false;
            if (form.dgvExistingCollections.Rows.Count != 0)
                form.dgvExistingCollections[1, 0].Selected = true;
            form.dgvExistingCollections.Update();
        }

        static public void dgvExistingCategories(CreatingObjectForm form)
        {
            form.dgvExistingCategories.DataSource = (from category in Control.container.Categories select
                new { category.Id, category.Name }).ToList();
            form.dgvExistingCategories.Columns[0].Visible = false;
            if (form.dgvExistingCategories.Rows.Count != 0)
                form.dgvExistingCategories[1, 0].Selected = true;
            form.dgvExistingCategories.Update();
        }

        static public void dgvObjectUsers(CreatingObjectForm form)
        {
            form.dgvObjectAuthors.DataSource = (from user in Control.tempUsers select
                new { user.Id, user.Name }).ToList();
            form.dgvObjectAuthors.Columns[0].Visible = false;
            if (form.dgvObjectAuthors.Rows.Count != 0)
                form.dgvObjectAuthors[1, 0].Selected = true;
            form.dgvObjectAuthors.Update();
        }

        static public void dgvObjectCollections(CreatingObjectForm form)
        {
            form.dgvObjectCollections.DataSource = (from collection in Control.tempCollections select
                new { collection.Id, collection.Name }).ToList();
            form.dgvObjectCollections.Columns[0].Visible = false;
            if (form.dgvObjectCollections.Rows.Count != 0)
                form.dgvObjectCollections[1, 0].Selected = true;
            form.dgvObjectCollections.Update();
        }

        static public void dgvObjectCategories(CreatingObjectForm form)
        {
            form.dgvObjectCategories.DataSource = (from newCategory in Control.tempCategories select
                new { newCategory.Id, newCategory.Name }).ToList();
            form.dgvObjectCategories.Columns[0].Visible = false;
            if (form.dgvObjectCategories.Rows.Count != 0)
                form.dgvObjectCategories[1, 0].Selected = true;
            form.dgvObjectCategories.Update();
        }
        #endregion

        // Точно так же как CreatinObjectForm, но другая форма (в формальном параметре)
        #region EditObjectForm
        static public void dgvExistingUsers(EditObjectForm form)
        {
            form.dgvExistingUsers.DataSource = (from user in Control.container.Users select 
                new { user.Id, user.Name }).ToList();
            form.dgvExistingUsers.Columns[0].Visible = false;
            if (form.dgvExistingUsers.Rows.Count != 0)
                form.dgvExistingUsers[1, 0].Selected = true;
            form.dgvExistingUsers.Update();
        }

        static public void dgvExistingCollections(EditObjectForm form)
        {
            form.dgvExistingCollections.DataSource = (from collection in Control.currentUser.Collections select
                new { collection.Id, collection.Name }).ToList();
            form.dgvExistingCollections.Columns[0].Visible = false;
            if (form.dgvExistingCollections.Rows.Count != 0)
                form.dgvExistingCollections[1, 0].Selected = true;
            form.dgvExistingCollections.Update();
        }

        static public void dgvExistingCategories(EditObjectForm form)
        {
            form.dgvExistingCategories.DataSource = (from category in Control.container.Categories select
                new { category.Id, category.Name }).ToList();
            form.dgvExistingCategories.Columns[0].Visible = false;
            if (form.dgvExistingCategories.Rows.Count != 0)
                form.dgvExistingCategories[1, 0].Selected = true;
            form.dgvExistingCategories.Update();
        }

        static public void dgvObjectUsers(EditObjectForm form)
        {
            form.dgvObjectAuthors.DataSource = (from user in Control.tempUsers select
                new { user.Id, user.Name }).ToList();
            form.dgvObjectAuthors.Columns[0].Visible = false;
            if (form.dgvObjectAuthors.Rows.Count != 0)
                form.dgvObjectAuthors[1, 0].Selected = true;
            form.dgvObjectAuthors.Update();
        }

        static public void dgvObjectCollections(EditObjectForm form)
        {
            form.dgvObjectCollections.DataSource = (from collection in Control.tempCollections select
                new { collection.Id, collection.Name }).ToList();
            form.dgvObjectCollections.Columns[0].Visible = false;
            if (form.dgvObjectCollections.Rows.Count != 0)
                form.dgvObjectCollections[1, 0].Selected = true;
            form.dgvObjectCollections.Update();
        }

        static public void dgvObjectCategories(EditObjectForm form)
        {
            form.dgvObjectCategories.DataSource = (from newCategory in Control.tempCategories select
                new { newCategory.Id, newCategory.Name }).ToList();
            form.dgvObjectCategories.Columns[0].Visible = false;
            if (form.dgvObjectCategories.Rows.Count != 0)
                form.dgvObjectCategories[1, 0].Selected = true;
            form.dgvObjectCategories.Update();
        }
        #endregion

        #region CreatingCollectionForm
        static public void dgvExistingObjects(CreatingCollectionForm form)
        {
            form.dgvExistingObjects.DataSource = (from obj in Control.currentUser.Objects select new { obj.Id, obj.Name }).ToList();
            form.dgvExistingObjects.Columns[0].Visible = false;
            if (form.dgvExistingObjects.Rows.Count != 0)
                form.dgvExistingObjects[1, 0].Selected = true;
            form.dgvExistingObjects.Update();
        }

        static public void dgvCollectionObjects(CreatingCollectionForm form)
        {
            form.dgvCollectionObjects.DataSource = (from obj in Control.tempObjects select new { obj.Id, obj.Name }).ToList();
            form.dgvCollectionObjects.Columns[0].Visible = false;
            if (form.dgvCollectionObjects.Rows.Count != 0)
                form.dgvCollectionObjects[1, 0].Selected = true;
            form.dgvCollectionObjects.Update();
        }
        #endregion

        // Точно так же как CreationCollectionForm, но другая форма (в формальном параметре)
        #region EditCollectionForm
        static public void dgvExistingObjects(EditCollectionForm form)
        {
            form.dgvExistingObjects.DataSource = (from obj in Control.currentUser.Objects select new { obj.Id, obj.Name }).ToList();
            form.dgvExistingObjects.Columns[0].Visible = false;
            if (form.dgvExistingObjects.Rows.Count != 0)
                form.dgvExistingObjects[1, 0].Selected = true;
            form.dgvExistingObjects.Update();
        }

        static public void dgvCollectionObjects(EditCollectionForm form)
        {
            form.dgvCollectionObjects.DataSource = (from obj in Control.tempObjects select new { obj.Id, obj.Name }).ToList();
            form.dgvCollectionObjects.Columns[0].Visible = false;
            if (form.dgvCollectionObjects.Rows.Count != 0)
                form.dgvCollectionObjects[1, 0].Selected = true;
            form.dgvCollectionObjects.Update();
        }
        #endregion

        #region ObjectInfoForm
        static public void dgvObjectComments(ObjectInfoForm form)
        {
            form.dgvComments.DataSource = (from comment in Control.currentObject.Comments select
                new { comment.Id, comment.User.Name, comment.Title, comment.Description, comment.Date }).ToList();
            form.dgvComments.Columns[0].Visible = false;
            if (form.dgvComments.Rows.Count != 0)
                form.dgvComments[1, 0].Selected = true;
            form.dgvComments.Update();
        }

        static public void dgvAuthors(ObjectInfoForm form)
        {
            form.dgvAuthors.DataSource = (from user in Control.currentObject.Users select
                new { user.Id, user.Name }).ToList();
            form.dgvAuthors.Columns[0].Visible = false;
            if (form.dgvAuthors.Rows.Count != 0)
                form.dgvAuthors[1, 0].Selected = true;
            form.dgvAuthors.Update();
        }

        static public void dgvCollections(ObjectInfoForm form)
        {
            form.dgvCollections.DataSource = (from collection in Control.currentObject.Collections select
                new { collection.Id, collection.Name, collection.Description, collection.CreatingDate, collection.AverageMark }).ToList();
            form.dgvCollections.Columns[0].Visible = false;
            if (form.dgvCollections.Rows.Count != 0)
                form.dgvCollections[1, 0].Selected = true;
            form.dgvCollections.Update();
        }

        static public void dgvCategories(ObjectInfoForm form)
        {
            form.dgvCategories.DataSource = (from category in Control.currentObject.Categories select
                new { category.Id, category.Name }).ToList();
            form.dgvCategories.Columns[0].Visible = false;
            if (form.dgvCategories.Rows.Count != 0)
                form.dgvCategories[1, 0].Selected = true;
            form.dgvCategories.Update();
        }

        static public void dgvMarks(ObjectInfoForm form)
        {
            form.dgvMarks.DataSource = (from mark in Control.currentObject.Marks select
                new { mark.Id, mark.Value, mark.User.Name }).ToList();
            form.dgvMarks.Columns[0].Visible = false;
            if (form.dgvMarks.Rows.Count != 0)
                form.dgvMarks[1, 0].Selected = true;
            form.dgvMarks.Update();
        }
        #endregion

        #region UserAccountForm
        static public void dgvObjects(UserAccountForm form)
        {
            form.dgvObjects.DataSource = (from obj in Control.currentUser.Objects select
                new { obj.Id, obj.Name, obj.Description, obj.CreatingDate, obj.AvarageMark }).ToList();
            form.dgvObjects.Columns[0].Visible = false;
            if (form.dgvObjects.Rows.Count != 0)
                form.dgvObjects[1, 0].Selected = true;
            form.dgvObjects.Update();
        }

        static public void dgvCollections(UserAccountForm form)
        {
            form.dgvCollections.DataSource = (from collection in Control.currentUser.Collections select
                new { collection.Id, collection.Name, collection.Description, collection.CreatingDate, collection.AverageMark }).ToList();
            form.dgvCollections.Columns[0].Visible = false;
            if (form.dgvCollections.Rows.Count != 0)
                form.dgvCollections[1, 0].Selected = true;
            form.dgvCollections.Update();
        }
        #endregion

        #region DataBaseForm
        static public void dgvDataBaseObjects(DataBaseForm form)
        {
            form.dgvDataBase.DataSource = (from obj in Control.container.Objects select
                new { obj.Id, obj.Name, obj.Description, obj.CreatingDate, obj.AvarageMark }).ToList();
            if (form.dgvDataBase.Rows.Count != 0)
                form.dgvDataBase[0, 0].Selected = true;
            form.dgvDataBase.Update();
        }

        static public void dgvDataBaseCollections(DataBaseForm form)
        {
            form.dgvDataBase.DataSource = (from collection in Control.container.Collections select
                new { collection.Id, collection.Name, collection.Description, collection.CreatingDate, collection.AverageMark }).ToList();
            if (form.dgvDataBase.Rows.Count != 0)
                form.dgvDataBase[0, 0].Selected = true;
            form.dgvDataBase.Update();
        }

        static public void dgvDataBaseUsers(DataBaseForm form)
        {
            form.dgvDataBase.DataSource = (from user in Control.container.Users select
                new { user.Id, user.Name }).ToList();
            if (form.dgvDataBase.Rows.Count != 0)
                form.dgvDataBase[0, 0].Selected = true;
            form.dgvDataBase.Update();
        }
        #endregion

        #region CollectionInfoForm
        static public void dgvCollectionComments(CollectionInfoForm form)
        {
            form.dgvComments.DataSource = (from comment in Control.currentCollection.Comments select
                new { comment.Id, comment.User.Name, comment.Title, comment.Description, comment.Date }).ToList();
            form.dgvComments.Columns[0].Visible = false;
            if (form.dgvComments.Rows.Count != 0)
                form.dgvComments[1, 0].Selected = true;
            form.dgvComments.Update();
        }

        static public void dgvCollectionCreators(CollectionInfoForm form)
        {
            form.dgvCreators.DataSource = (from user in Control.currentCollection.Users select
                new { user.Id, user.Name }).ToList();
            form.dgvCreators.Columns[0].Visible = false;
            if (form.dgvCreators.Rows.Count != 0)
                form.dgvCreators[1, 0].Selected = true;
            form.dgvCreators.Update();
        }

        static public void dgvCollectionObjects(CollectionInfoForm form)
        {
            form.dgvObjects.DataSource = (from obj in Control.currentCollection.Objects select
                new { obj.Id, obj.Name, obj.Description, obj.CreatingDate, obj.AvarageMark }).ToList();
            form.dgvObjects.Columns[0].Visible = false;
            if (form.dgvObjects.Rows.Count != 0)
                form.dgvObjects[1, 0].Selected = true;
            form.dgvObjects.Update();
        }

        static public void dgvCollectionCategories(CollectionInfoForm form)
        {
            form.dgvCategories.DataSource = (from category in Control.currentCollection.Categories select
                new { category.Id, category.Name }).ToList();
            form.dgvCategories.Columns[0].Visible = false;
            if (form.dgvCategories.Rows.Count != 0)
                form.dgvCategories[1, 0].Selected = true;
            form.dgvCategories.Update();
        }

        static public void dgvCollectionMarks(CollectionInfoForm form)
        {
            form.dgvMarks.DataSource = (from mark in Control.currentCollection.Marks select
                new { mark.Id, mark.Value }).ToList();
            form.dgvMarks.Columns[0].Visible = false;
            if (form.dgvMarks.Rows.Count != 0)
                form.dgvMarks[1, 0].Selected = true;
            form.dgvMarks.Update();
        }
        #endregion

        #region QueryForm
        static public void dgvQueries(QueryForm form)
        {
            form.dgvQueries.DataSource = (from query in Control.tempQueries select
                new { query.Entity, query.Property, query.Condition, query.Value, query.Link }).ToList();
            if (form.dgvQueries.Rows.Count != 0)
                form.dgvQueries[0, 0].Selected = true;
            form.dgvQueries.Update();
        }

        static public void dgvObjectResults(QueryForm form)
        {
            form.dgvResult.DataSource = (from obj in Control.tempObjectResult select
                new { obj.Id, obj.Name, obj.Description, obj.CreatingDate, obj.AvarageMark }).ToList();
            if (form.dgvResult.Rows.Count != 0)
                form.dgvResult[0, 0].Selected = true;
            form.dgvResult.Update();
        }

        static public void dgvCollectionResults(QueryForm form)
        {
            form.dgvResult.DataSource = (from collection in Control.tempCollectionResult select
                new { collection.Id, collection.Name, collection.Description, collection.CreatingDate, collection.AverageMark }).ToList();
            if (form.dgvResult.Rows.Count != 0)
                form.dgvResult[0, 0].Selected = true;
            form.dgvResult.Update();
        }

        static public void dgvUserResult(QueryForm form)
        {
            form.dgvResult.DataSource = (from user in Control.tempUserResult select
                new { user.Id, user.Name }).ToList();
            if (form.dgvResult.Rows.Count != 0)
                form.dgvResult[0, 0].Selected = true;
            form.dgvResult.Update();
        }
        #endregion
    }
}
