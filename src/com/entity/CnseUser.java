package com.entity;

import java.util.Set;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.Table;



/**
 * CnseUser entity. @author MyEclipse Persistence Tools
 */
@Entity
@Table(name="cnse_user")
public class CnseUser {
	
	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	@Id
    @GeneratedValue
	private int id;
	
	private String authority;
	private String name;
	private String password;
	// Constructors
    

	public String getAuthority() {
		return authority;
	}

	public void setAuthority(String authority) {
		this.authority = authority;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getPassword() {
		return password;
	}

	public void setPassword(String password) {
		this.password = password;
	}

	/** default constructor */
	public CnseUser() {
	}

	

}
