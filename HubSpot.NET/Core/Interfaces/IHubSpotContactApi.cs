﻿using System.Collections.Generic;
using HubSpot.NET.Api.Company;
using HubSpot.NET.Api.Contact;
using HubSpot.NET.Api.Contact.Dto;

namespace HubSpot.NET.Core.Interfaces
{
    public interface IHubSpotContactApi : IHubSpotContactApi<ContactHubSpotModel>
    { }

    public interface IHubSpotContactApi<T> : ICRUDable<T>
        where T : IHubSpotModel
    {
        ContactListHubSpotModel<T> List(ListRequestOptions opts = null);
        ContactListHubSpotModel<T> RecentlyCreated(ListRecentRequestOptions opts = null);
        ContactListHubSpotModel<T> RecentlyUpdated(ListRecentRequestOptions opts = null);
        ContactSearchHubSpotModel<T> Search(ContactSearchRequestOptions opts = null);
        T GetByEmail(string email);
        T GetByUserToken(string userToken);
        T CreateOrUpdate(T entity);
        void Batch(List<T> entities);
    }
}
