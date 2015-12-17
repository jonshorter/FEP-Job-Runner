Namespace JobRunner_Models
    Public Class Author
        Public Property login As String
        Public Property id As Integer
        Public Property avatar_url As String
        Public Property gravatar_id As String
        Public Property url As String
        Public Property html_url As String
        Public Property followers_url As String
        Public Property following_url As String
        Public Property gists_url As String
        Public Property starred_url As String
        Public Property subscriptions_url As String
        Public Property organizations_url As String
        Public Property repos_url As String
        Public Property events_url As String
        Public Property received_events_url As String
        Public Property type As String
        Public Property site_admin As Boolean
    End Class

    Public Class Uploader
        Public Property login As String
        Public Property id As Integer
        Public Property avatar_url As String
        Public Property gravatar_id As String
        Public Property url As String
        Public Property html_url As String
        Public Property followers_url As String
        Public Property following_url As String
        Public Property gists_url As String
        Public Property starred_url As String
        Public Property subscriptions_url As String
        Public Property organizations_url As String
        Public Property repos_url As String
        Public Property events_url As String
        Public Property received_events_url As String
        Public Property type As String
        Public Property site_admin As Boolean
    End Class

    Public Class Asset
        Public Property url As String
        Public Property id As Integer
        Public Property name As String
        Public Property label As Object
        Public Property uploader As Uploader
        Public Property content_type As String
        Public Property state As String
        Public Property size As Integer
        Public Property download_count As Integer
        Public Property created_at As DateTime
        Public Property updated_at As DateTime
        Public Property browser_download_url As String
    End Class

    Public Class GitHubRelease
        Public Property url As String
        Public Property assets_url As String
        Public Property upload_url As String
        Public Property html_url As String
        Public Property id As Integer
        Public Property tag_name As String
        Public Property target_commitish As String
        Public Property name As String
        Public Property draft As Boolean
        Public Property author As Author
        Public Property prerelease As Boolean
        Public Property created_at As DateTime
        Public Property published_at As DateTime
        Public Property assets As Asset()
        Public Property tarball_url As String
        Public Property zipball_url As String
        Public Property body As String
    End Class
End Namespace
