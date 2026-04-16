package com.gtd.controller;

import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/api")
public class AuthController {

    @PostMapping("/login")
    public String login(@RequestBody LoginRequest loginRequest) {
        // TODO: Add authentication logic
        if ("admin".equals(loginRequest.getUsername()) && "password".equals(loginRequest.getPassword())) {
            return "dummy-auth-token";
        } else {
            throw new RuntimeException("Invalid credentials");
        }
    }

    static class LoginRequest {
        private String username;
        private String password;

        public String getUsername() { return username; }
        public void setUsername(String username) { this.username = username; }

        public String getPassword() { return password; }
        public void setPassword(String password) { this.password = password; }
    }
}