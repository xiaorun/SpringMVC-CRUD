package com.service;

import java.util.List;

import com.entity.Team;

public interface TeamService {
	 
    public void addTeam(Team team);
    public void updateTeam(Team team);
    public Team getTeam(int id);
    public void deleteTeam(int id);
    public List getTeams();
 
}