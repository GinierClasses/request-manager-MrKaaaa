using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequestManager.Models;

namespace RequestManager.Controllers
{
    public class RequestController
    {
        private BindingList<Request> _requests = new BindingList<Request>();
        private BindingList<Status> _status = new BindingList<Status>();

        /// <summary>
        /// Création d'une nouvelle requête en prenant en compte les paramètres donnés
        /// </summary>
        /// <param name="title">Champ Titre</param>
        /// <param name="description">Champ Description</param>
        /// <param name="createDon">Date de création générée auto.</param>
        /// <param name="updateDon">Date de modification générée auto.</param>
        /// <param name="status">Récupération liste Statut</param>
        /// <param name="priority">Récupération liste Priorité</param>
        public void Create(string title, string description, DateTime createDon, DateTime updateDon, Status status, Priority priority)
        {
            _requests.Add(new Request(GetNewId(), title, description, createDon, updateDon, status, priority));
        }

        /// <summary>
        /// Récupération d'une requête possédant l'ID demandé
        /// </summary>
        /// <param name="id">id de la requête à chercher</param>
        /// <returns></returns>
        public Request GetById(int id)
        {
            return id > 0 ? _requests.First(a => a.Id == id) : null;
        }

        /// <summary>
        /// Récupération des requêtes par ordre de priorités et par status
        /// </summary>
        /// <param name="status"></param>
        public void GetByStatusOrderByPriority(Status status)
        {

        }

        /// <summary>
        /// Mise à jour des infos d'une requête
        /// </summary>
        /// <param name="id">id de la requête à modifier</param>
        /// <param name="title">Champ Titre</param>
        /// <param name="description">Champ Description</param>
        /// <param name="createDon">Date de création générée auto.</param>
        /// <param name="updateDon">Date de modification générée auto.</param>
        /// <param name="status">Récupération liste Statut</param>
        /// <param name="priority">Récupération liste Priorité</param>
        public void Update(int id, string title, string description, DateTime createDon, DateTime updateDon, Status status, Priority priority)
        {

        }

        /// <summary>
        /// Suppression d'une requête 
        /// </summary>
        /// <param name="id">id de la requête à supprimer</param>
        public void Delete(int id)
        {
            if (_requests.Any(a => a.Id == id))
                _requests.RemoveAt(_requests.IndexOf(_requests.First(a => a.Id == id)));
        }



        private int GetNewId()
        {
            return _requests.Any() ? _requests.Last().Id + 1 : 1;

        }

    }
}
