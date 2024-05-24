pipeline {
    agent any

    environment {
        DOTNET_SDK_VERSION = '5.0' // Specify the .NET SDK version you are using
    }

    stages {
        stage('Checkout') {
            steps {
                   git branch: 'dev', url: 'https://githyd.epam.com/epm-pe2n/team-1.git'
            }
        }

        stage('Restore') {
            steps {
                dir('development/Authentication/Authentication.API') {
                    sh 'dotnet restore'
                }
            }
        }

        stage('Build') {
            steps {
                sh 'dotnet build --configuration Release --no-restore'
            }
        }

        stage('Test') {
            steps {
                sh 'dotnet test --no-build'
            }
        }
    }

    post {
        always {
            archiveArtifacts artifacts: '**/bin/**/*.dll', allowEmptyArchive: true
            junit 'TestResults/*.xml'
        }
        success {
            echo 'Build succeeded!'
        }
        failure {
            echo 'Build failed!'
        }
    }
}

