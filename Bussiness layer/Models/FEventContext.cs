using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Bussiness_layer
{
    public partial class FEventContext : DbContext
    {
        public FEventContext()
        {
        }

        public FEventContext(DbContextOptions<FEventContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Follow> Follows { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Video> Videos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);Uid=sa;Pwd=12345;Database=FEvent");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment1)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("comment");

                entity.Property(e => e.IdEvent).HasColumnName("id_event");

                entity.Property(e => e.IdReplyComment).HasColumnName("id_reply_comment");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Time)
                    .HasPrecision(0)
                    .HasColumnName("time");

                entity.HasOne(d => d.IdEventNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.IdEvent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Event");

                entity.HasOne(d => d.IdReplyCommentNavigation)
                    .WithMany(p => p.InverseIdReplyCommentNavigation)
                    .HasForeignKey(d => d.IdReplyComment)
                    .HasConstraintName("FK_Comment_Comment");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_User");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.ToTable("Event");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Begin)
                    .HasPrecision(0)
                    .HasColumnName("begin");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(1500)
                    .HasColumnName("content");

                entity.Property(e => e.Create)
                    .HasPrecision(0)
                    .HasColumnName("create");

                entity.Property(e => e.End)
                    .HasPrecision(0)
                    .HasColumnName("end");

                entity.Property(e => e.Follow).HasColumnName("follow");

                entity.Property(e => e.IdCategory).HasColumnName("id_category");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Like).HasColumnName("like");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Vote).HasColumnName("vote");
            });

            modelBuilder.Entity<Follow>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Follow");

                entity.Property(e => e.IdEvent).HasColumnName("id_event");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.HasOne(d => d.IdEventNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdEvent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Follow_Event");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Follow_User");
            });

            modelBuilder.Entity<Images>(entity =>
            {
                entity.ToTable("Image");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdEvent).HasColumnName("id_event");

                entity.Property(e => e.Image1)
                    .HasMaxLength(50)
                    .HasColumnName("image");

                entity.HasOne(d => d.IdEventNavigation)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.IdEvent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Image_Event");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("password")
                    .IsFixedLength(true);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("phone")
                    .IsFixedLength(true);

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Role");
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.ToTable("Video");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdEvent).HasColumnName("id_event");

                entity.Property(e => e.Video1)
                    .HasMaxLength(50)
                    .HasColumnName("video");

                entity.HasOne(d => d.IdEventNavigation)
                    .WithMany(p => p.Videos)
                    .HasForeignKey(d => d.IdEvent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Video_Event");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
