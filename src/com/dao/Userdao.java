package com.dao;

import java.util.List;

import org.hibernate.Query;
import org.hibernate.SessionFactory;

import com.entity.CnseUser;

public class Userdao {
	private SessionFactory sessionFactory;
	
	public void setSessionFactory(SessionFactory sessionFactory) {
		this.sessionFactory = sessionFactory;
	}

	public SessionFactory getSessionFactory() {
		return sessionFactory;
	}
	
	public List<CnseUser> getAllCase() {
		Query query = this.sessionFactory.getCurrentSession().createQuery(
				"from CnseUser");
		List<CnseUser> list = query.list();
		return list;
	}
}
