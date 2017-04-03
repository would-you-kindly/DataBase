using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateBase
{
    class Control
    {
        static public ModelContainer container = new ModelContainer();

        static public User currentUser;
        static public Object currentObject;
        static public Collection currentCollection;
        static public File currentFile;

        static public List<User> tempUsers = new List<User>();
        static public List<Object> tempObjects = new List<Object>();
        static public List<Category> tempCategories = new List<Category>();
        static public List<Collection> tempCollections = new List<Collection>();

        static public List<Query> tempQueries = new List<Query>();
        static public List<Object> tempObjectResult = new List<Object>();
        static public List<Collection> tempCollectionResult = new List<Collection>();
        static public List<User> tempUserResult = new List<User>();

        #region ForgetInfo
        static public void ForgetAllTempInfo()
        {
            tempUsers.Clear();
            tempObjects.Clear();
            tempCategories.Clear();
            tempCollections.Clear();
        }

        static public void ForgetCurrentFile()
        {
            currentFile = null;
            currentFile = new File();
        }

        static public void ForgetCurrentUser()
        {
            currentUser = null;
            currentUser = new User();
        }

        static public void ForgetCurrentObject()
        {
            currentObject = null;
            currentObject = new Object();
        }

        static public void ForgetCurrentCollection()
        {
            currentCollection = null;
            currentCollection = new Collection();
        }
        #endregion

        #region FindID
        static public int FindID(DataGridView dgv)
        {
            return (int)dgv.CurrentRow.Cells[0].Value;
        }
        #endregion

        #region Message
        static public void Exclamation(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        static public void Information(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        static public DialogResult Question(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
        #endregion

        #region Deleting
        static public void DeleteObject(Object obj)
        {
            Object deletingObject = new Object();
            deletingObject = container.Objects.Find(obj.Id);

            // Обновляем коллекции, из которых удаляется объект
            foreach (Collection collection in deletingObject.Collections)
            {
                Collection changingCollection = new Collection();
                changingCollection = container.Collections.Find(collection.Id);
                changingCollection.Categories.Clear();
                changingCollection.Users.Clear();

                foreach (Object collectionObject in collection.Objects)
                {
                    if (deletingObject == collectionObject)
                        continue;

                    foreach (Category category in collectionObject.Categories)
                    {
                        changingCollection.Categories.Add(category);
                    }
                    foreach (User user in collectionObject.Users)
                    {
                        changingCollection.Users.Add(user);
                    }
                }
                changingCollection.Categories.Distinct();
                changingCollection.Users.Distinct();
            }

            container.Files.Remove(deletingObject.File);
            container.Marks.RemoveRange(deletingObject.Marks);
            container.Comments.RemoveRange(deletingObject.Comments);

            deletingObject.Categories.Clear();

            foreach (User user in deletingObject.Users)
            {
                user.Objects.Remove(deletingObject);
            }

            container.Objects.Remove(deletingObject);

            // Если остались коллекции, где больше нет объектов, то удаляем их тоже
            foreach (Collection collection in Control.container.Collections)
            {
                if (collection.Objects.Count == 0)
                {
                    Exclamation(string.Format("В коллекии \"{0}\" больше нет объектов, эта коллекция также удаляется.", collection.Name), "Удаление коллекции");
                    DeleteCollection(collection, true);
                }
            }
            container.SaveChanges();
        }

        static public void DeleteCollection(Collection collection, bool onlyDelete = false)
        {
            Collection deletingCollection = new Collection();
            deletingCollection = container.Collections.Find(collection.Id);

            container.Marks.RemoveRange(deletingCollection.Marks);
            container.Comments.RemoveRange(deletingCollection.Comments);

            deletingCollection.Categories.Clear();
            deletingCollection.Objects.Clear();
            deletingCollection.Users.Clear();

            container.Collections.Remove(deletingCollection);

            if (!onlyDelete)
            {
                container.SaveChanges();
            }
        }
        #endregion
    }
}
