package com.dao;

import java.util.List;

import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.Transaction;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import com.entity.Team;

@Repository
public class TeamDAOImpl implements TeamDAO {
 
    @Autowired
    private SessionFactory sessionFactory;
 
    private Session getCurrentSession() {
        return sessionFactory.getCurrentSession();
    }
 
    public void addTeam(Team team) {
        getCurrentSession().save(team);
    }
 
    public void updateTeam(Team team) {
    	Session session = sessionFactory.getCurrentSession();
    	Transaction tran = session.beginTransaction();//启动事务
    	 Team teamToUpdate = getTeam(team.getId());
    	 teamToUpdate.setName(team.getName());
    	 teamToUpdate.setRating(team.getRating());
    	 session.flush();
    	 session.update(teamToUpdate);
    	 
    	 session.flush();
    	 tran.commit();//提交事务
    }
 
    public Team getTeam(int id) {
        Team team = (Team) getCurrentSession().get(Team.class, id);
        return team;
    }
 
    public void deleteTeam(int id) {
    	Session session = sessionFactory.getCurrentSession();
		Transaction tran = session.beginTransaction();//启动事务
        Team team = getTeam(id);
        if (team != null)
			session.flush();
		session.delete(team);
		session.flush();
		session.getTransaction().commit();
    }
 
    @SuppressWarnings("unchecked")
    public List
 
          getTeams() {
        return getCurrentSession().createQuery("from Team").list();
    }
 
}