package com.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class LinkController {
 
	/*@Resource(name = "Userdao")
	private Userdao userdao;
	
	public Userdao getUserdao() {
		return userdao;
	}
	public void setUserdao(Userdao userdao) {
		this.userdao = userdao;
	}
	//Userdao userdao = new Userdao();
	@RequestMapping({"/index"})
	public String mainPage(HttpServletRequest request){
		 System.out.println("f");
		List<CnseUser> list=new ArrayList<CnseUser>();
		list = this.userdao.getAllCase();
		request.setAttribute("personList", list);
		return "/MyJsp";
	}	*/
	@RequestMapping(value="/")
    public ModelAndView mainPage() {
        return new ModelAndView("home");
    }
 
    @RequestMapping(value="/index")
    public ModelAndView indexPage() {
        return new ModelAndView("home");
    }
}